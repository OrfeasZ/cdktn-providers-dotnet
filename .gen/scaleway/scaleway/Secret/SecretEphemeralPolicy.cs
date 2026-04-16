using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Secret
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.secret.SecretEphemeralPolicy")]
    public class SecretEphemeralPolicy : scaleway.Secret.ISecretEphemeralPolicy
    {
        /// <summary>Action to perform when the version of a secret expires.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#action Secret#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        private object? _expiresOnceAccessed;

        /// <summary>True if the secret version expires after a single user access.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/secret#expires_once_accessed Secret#expires_once_accessed}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiresOnceAccessed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExpiresOnceAccessed
        {
            get => _expiresOnceAccessed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _expiresOnceAccessed = value;
            }
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
            get;
            set;
        }
    }
}
