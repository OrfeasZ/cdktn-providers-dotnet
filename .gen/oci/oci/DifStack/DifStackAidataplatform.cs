using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.difStack.DifStackAidataplatform")]
    public class DifStackAidataplatform : oci.DifStack.IDifStackAidataplatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#default_workspace_name DifStack#default_workspace_name}.</summary>
        [JsiiProperty(name: "defaultWorkspaceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultWorkspaceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/dif_stack#instance_id DifStack#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceId
        {
            get;
            set;
        }
    }
}
