using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnectGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecProperties")]
    public class CoreCrossConnectGroupMacsecProperties : oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#state CoreCrossConnectGroup#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#encryption_cipher CoreCrossConnectGroup#encryption_cipher}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionCipher
        {
            get;
            set;
        }

        private object? _isUnprotectedTrafficAllowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#is_unprotected_traffic_allowed CoreCrossConnectGroup#is_unprotected_traffic_allowed}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#primary_key CoreCrossConnectGroup#primary_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecPropertiesPrimaryKey\"}", isOptional: true)]
        public oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecPropertiesPrimaryKey? PrimaryKey
        {
            get;
            set;
        }
    }
}
