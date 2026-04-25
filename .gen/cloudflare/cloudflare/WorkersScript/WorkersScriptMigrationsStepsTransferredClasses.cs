using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.WorkersScript
{
    [JsiiByValue(fqn: "cloudflare.workersScript.WorkersScriptMigrationsStepsTransferredClasses")]
    public class WorkersScriptMigrationsStepsTransferredClasses : cloudflare.WorkersScript.IWorkersScriptMigrationsStepsTransferredClasses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#from WorkersScript#from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? From
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#from_script WorkersScript#from_script}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromScript", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FromScript
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/workers_script#to WorkersScript#to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? To
        {
            get;
            set;
        }
    }
}
