using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsBuildRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsBuildRun.DevopsBuildRunBuildRunArgumentsItems")]
    public class DevopsBuildRunBuildRunArgumentsItems : oci.DevopsBuildRun.IDevopsBuildRunBuildRunArgumentsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#name DevopsBuildRun#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_build_run#value DevopsBuildRun#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
