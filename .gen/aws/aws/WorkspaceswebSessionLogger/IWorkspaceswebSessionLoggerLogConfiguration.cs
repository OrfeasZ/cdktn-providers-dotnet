using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebSessionLogger
{
    [JsiiInterface(nativeType: typeof(IWorkspaceswebSessionLoggerLogConfiguration), fullyQualifiedName: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfiguration")]
    public interface IWorkspaceswebSessionLoggerLogConfiguration
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#s3 WorkspaceswebSessionLogger#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfigurationS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? S3
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspaceswebSessionLoggerLogConfiguration), fullyQualifiedName: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspaceswebSessionLogger.IWorkspaceswebSessionLoggerLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#s3 WorkspaceswebSessionLogger#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerLogConfigurationS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? S3
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
