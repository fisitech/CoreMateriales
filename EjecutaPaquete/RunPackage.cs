using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Reflection;
using System.Diagnostics;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static int RunPackage(string NombreArchivo, SqlBytes BytesArchivo, string NombrePaquete, string PassPaquete)
    {
        try
        {
            //validar si existe
            File.Delete(@"c:\temp\runpackage.log");
            File.Delete(@"c:\temp\" + NombreArchivo);
            File.Delete(@"c:\temp\" + NombrePaquete + ".dtsx");
            ExtractEmbeddedResource(@"c:\temp", "EjecutaPaquete", NombrePaquete + ".dtsx");

            byte[] barchivo = BytesArchivo.Value;            
            System.IO.FileStream _FileStream =
            new System.IO.FileStream(@"c:\temp\" +NombreArchivo,
                                    System.IO.FileMode.Create,
                                    System.IO.FileAccess.Write);
            _FileStream.Write(barchivo, 0, (int)barchivo.Length);
            _FileStream.Close();

            string filepath = @" ""\Package.Variables[User::filepath].Properties[Value];c:\temp\" + NombreArchivo + @""" ";
            int result = ExecuteDTExec(@"""C:\Program Files\Microsoft SQL Server\90\DTS\Binn\DTExec.exe"" ", PassPaquete, @"c:\Temp\" + NombrePaquete + ".dtsx", filepath);

            return result;
            
        }
        catch (Exception _Exception)
        {
            //return _Exception.Message.ToString();
            return -1;
        }
    }


    private static void ExtractEmbeddedResource(string outputDir, string resourceLocation, string file)
    {

        using (System.IO.Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceLocation + @"." + file))
        {
            using (System.IO.FileStream fileStream = new System.IO.FileStream(System.IO.Path.Combine(outputDir, file), System.IO.FileMode.Create))
            {
                for (int i = 0; i < stream.Length; i++)
                {
                    fileStream.WriteByte((byte)stream.ReadByte());
                }
                fileStream.Close();
            }
        }

    }

    private static int ExecuteDTExec(string command, string packpass, string paquete, string variables)
    {
        ProcessStartInfo info = new ProcessStartInfo(command);
        try
        {
            info.RedirectStandardOutput = false;
            info.RedirectStandardError = false;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.Arguments = string.Format(@"/f """ + paquete + @""" /DECRYPT " + packpass  + " /set " + variables);

            int processResults;
            using (Process p = Process.Start(info))
            {
                p.WaitForExit();
                processResults = p.ExitCode;
                //p.StandardOutput;
            }
            return processResults;
        }

        catch (Exception ex)
        {
            return -1;
        }
    }
};