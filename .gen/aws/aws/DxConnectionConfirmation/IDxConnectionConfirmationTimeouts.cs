using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DxConnectionConfirmation
{
    [JsiiInterface(nativeType: typeof(IDxConnectionConfirmationTimeouts), fullyQualifiedName: "aws.dxConnectionConfirmation.DxConnectionConfirmationTimeouts")]
    public interface IDxConnectionConfirmationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/dx_connection_confirmation#create DxConnectionConfirmation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxConnectionConfirmationTimeouts), fullyQualifiedName: "aws.dxConnectionConfirmation.DxConnectionConfirmationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DxConnectionConfirmation.IDxConnectionConfirmationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/dx_connection_confirmation#create DxConnectionConfirmation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
