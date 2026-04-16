using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebTrustStore
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspaceswebTrustStore.WorkspaceswebTrustStoreCertificate")]
    public class WorkspaceswebTrustStoreCertificate : aws.WorkspaceswebTrustStore.IWorkspaceswebTrustStoreCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_trust_store#body WorkspaceswebTrustStore#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public string Body
        {
            get;
            set;
        }
    }
}
