using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Zeth.Poc.Shared.Helper
{
    public static class TerraformHelper
    {
        public static (int ExitCode, string Output) Execute(string terraformExecutable, string workingDirectory, string command, Dictionary<string, string> vars = null)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = terraformExecutable,
                    Arguments = $"{command} -auto-approve",
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    WorkingDirectory = workingDirectory,
                    CreateNoWindow = true,
                }
            };

            if (vars != null)
            {
                var varsString = string.Join(" ", vars.Select(x => $"-var {x.Key}={x.Value}"));
                process.StartInfo.Arguments = process.StartInfo.Arguments + " " + varsString;
            }

            process.Start();
            var output = process.StandardOutput.ReadToEnd();
            var error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            return (process.ExitCode, output + error);
        }
    }
}
