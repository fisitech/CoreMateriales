using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;
namespace MaterialCore.Clases
{
    class SSIS
    {
    public void Execute_Package(string pkgLocation,string filepath)
    {           
        
        Package pkg;
        Microsoft.SqlServer.Dts.Runtime.Application app;
        Microsoft.SqlServer.Dts.Runtime.DTSExecResult pkgResults;
        Variables vars;

        app = new Microsoft.SqlServer.Dts.Runtime.Application();
        try
        {
            pkg = app.LoadPackage(pkgLocation, null);
            vars = pkg.Variables;
            vars["filepath"].Value = filepath;

            pkgResults = pkg.Execute(null, vars, null, null, null);
            if (pkgResults == DTSExecResult.Success)
                System.Windows.Forms.MessageBox.Show("Package ran successfully");
            else
                System.Windows.Forms.MessageBox.Show("Package failed");
        }catch (Exception ex){
            System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
        }


    }
    }
}
