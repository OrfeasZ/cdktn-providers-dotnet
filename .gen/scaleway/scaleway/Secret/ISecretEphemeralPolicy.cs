using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Secret
{
    [JsiiInterface(nativeType: typeof(ISecretEphemeralPolicy), fullyQualifiedName: "scaleway.secret.SecretEphemeralPolicy")]
    public interface ISecretEphemeralPolicy
    {
        /// <summary>Action to perform when the version of a secret expires.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#action Secret#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>True if the secret version expires after a single user access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#expires_once_accessed Secret#expires_once_accessed}
        /// </remarks>
        [JsiiProperty(name: "expiresOnceAccessed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExpiresOnceAccessed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time frame, from one second and up to one year, during which the secret's versions are valid.</summary>
        /// <remarks>
        /// Has to be specified in Go Duration format
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#ttl Secret#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretEphemeralPolicy), fullyQualifiedName: "scaleway.secret.SecretEphemeralPolicy")]
        internal sealed class _Proxy : DeputyBase, scaleway.Secret.ISecretEphemeralPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Action to perform when the version of a secret expires.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#action Secret#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>True if the secret version expires after a single user access.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#expires_once_accessed Secret#expires_once_accessed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresOnceAccessed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExpiresOnceAccessed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Time frame, from one second and up to one year, during which the secret's versions are valid.</summary>
            /// <remarks>
            /// Has to be specified in Go Duration format
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#ttl Secret#ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ttl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
