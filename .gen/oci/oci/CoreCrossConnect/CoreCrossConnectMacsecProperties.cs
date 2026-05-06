using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreCrossConnect.CoreCrossConnectMacsecProperties")]
    public class CoreCrossConnectMacsecProperties : oci.CoreCrossConnect.ICoreCrossConnectMacsecProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#state CoreCrossConnect#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#encryption_cipher CoreCrossConnect#encryption_cipher}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionCipher
        {
            get;
            set;
        }

        private object? _isUnprotectedTrafficAllowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#is_unprotected_traffic_allowed CoreCrossConnect#is_unprotected_traffic_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isUnprotectedTrafficAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsUnprotectedTrafficAllowed
        {
            get => _isUnprotectedTrafficAllowed;
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
                _isUnprotectedTrafficAllowed = value;
            }
        }

        /// <summary>primary_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#primary_key CoreCrossConnect#primary_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey\"}", isOptional: true)]
        public oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey? PrimaryKey
        {
            get;
            set;
        }
    }
}
