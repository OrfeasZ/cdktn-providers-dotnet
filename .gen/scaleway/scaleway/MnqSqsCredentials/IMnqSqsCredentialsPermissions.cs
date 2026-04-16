using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MnqSqsCredentials
{
    [JsiiInterface(nativeType: typeof(IMnqSqsCredentialsPermissions), fullyQualifiedName: "scaleway.mnqSqsCredentials.MnqSqsCredentialsPermissions")]
    public interface IMnqSqsCredentialsPermissions
    {
        /// <summary>Allow manage the associated resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_credentials#can_manage MnqSqsCredentials#can_manage}
        /// </remarks>
        [JsiiProperty(name: "canManage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CanManage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow publish messages to the service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_credentials#can_publish MnqSqsCredentials#can_publish}
        /// </remarks>
        [JsiiProperty(name: "canPublish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CanPublish
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allow receive messages from the service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_credentials#can_receive MnqSqsCredentials#can_receive}
        /// </remarks>
        [JsiiProperty(name: "canReceive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CanReceive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMnqSqsCredentialsPermissions), fullyQualifiedName: "scaleway.mnqSqsCredentials.MnqSqsCredentialsPermissions")]
        internal sealed class _Proxy : DeputyBase, scaleway.MnqSqsCredentials.IMnqSqsCredentialsPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allow manage the associated resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_credentials#can_manage MnqSqsCredentials#can_manage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canManage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanManage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow publish messages to the service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_credentials#can_publish MnqSqsCredentials#can_publish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canPublish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanPublish
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow receive messages from the service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mnq_sqs_credentials#can_receive MnqSqsCredentials#can_receive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canReceive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanReceive
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
