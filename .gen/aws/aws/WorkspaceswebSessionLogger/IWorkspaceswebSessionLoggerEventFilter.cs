using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspaceswebSessionLogger
{
    [JsiiInterface(nativeType: typeof(IWorkspaceswebSessionLoggerEventFilter), fullyQualifiedName: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerEventFilter")]
    public interface IWorkspaceswebSessionLoggerEventFilter
    {
        /// <summary>all block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#all WorkspaceswebSessionLogger#all}
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerEventFilterAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#include WorkspaceswebSessionLogger#include}.</summary>
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspaceswebSessionLoggerEventFilter), fullyQualifiedName: "aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerEventFilter")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspaceswebSessionLogger.IWorkspaceswebSessionLoggerEventFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#all WorkspaceswebSessionLogger#all}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspaceswebSessionLogger.WorkspaceswebSessionLoggerEventFilterAll\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/workspacesweb_session_logger#include WorkspaceswebSessionLogger#include}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Include
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
