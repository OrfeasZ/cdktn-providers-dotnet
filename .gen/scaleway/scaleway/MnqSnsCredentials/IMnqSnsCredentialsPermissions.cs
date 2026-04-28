using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MnqSnsCredentials
{
    [JsiiInterface(nativeType: typeof(IMnqSnsCredentialsPermissions), fullyQualifiedName: "scaleway.mnqSnsCredentials.MnqSnsCredentialsPermissions")]
    public interface IMnqSnsCredentialsPermissions
    {
        /// <summary>Allow manage the associated resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mnq_sns_credentials#can_manage MnqSnsCredentials#can_manage}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mnq_sns_credentials#can_publish MnqSnsCredentials#can_publish}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mnq_sns_credentials#can_receive MnqSnsCredentials#can_receive}
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

        [JsiiTypeProxy(nativeType: typeof(IMnqSnsCredentialsPermissions), fullyQualifiedName: "scaleway.mnqSnsCredentials.MnqSnsCredentialsPermissions")]
        internal sealed class _Proxy : DeputyBase, scaleway.MnqSnsCredentials.IMnqSnsCredentialsPermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allow manage the associated resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mnq_sns_credentials#can_manage MnqSnsCredentials#can_manage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canManage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanManage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow publish messages to the service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mnq_sns_credentials#can_publish MnqSnsCredentials#can_publish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canPublish", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CanPublish
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Allow receive messages from the service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/mnq_sns_credentials#can_receive MnqSnsCredentials#can_receive}
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
