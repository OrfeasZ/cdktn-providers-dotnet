using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebTrustStore
{
    [JsiiInterface(nativeType: typeof(IWorkspaceswebTrustStoreCertificate), fullyQualifiedName: "aws.workspaceswebTrustStore.WorkspaceswebTrustStoreCertificate")]
    public interface IWorkspaceswebTrustStoreCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_trust_store#body WorkspaceswebTrustStore#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        string Body
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspaceswebTrustStoreCertificate), fullyQualifiedName: "aws.workspaceswebTrustStore.WorkspaceswebTrustStoreCertificate")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspaceswebTrustStore.IWorkspaceswebTrustStoreCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/workspacesweb_trust_store#body WorkspaceswebTrustStore#body}.</summary>
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
            public string Body
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
