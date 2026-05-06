using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiInterface(nativeType: typeof(ICoreCrossConnectMacsecProperties), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectMacsecProperties")]
    public interface ICoreCrossConnectMacsecProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#state CoreCrossConnect#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#encryption_cipher CoreCrossConnect#encryption_cipher}.</summary>
        [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionCipher
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#is_unprotected_traffic_allowed CoreCrossConnect#is_unprotected_traffic_allowed}.</summary>
        [JsiiProperty(name: "isUnprotectedTrafficAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsUnprotectedTrafficAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>primary_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#primary_key CoreCrossConnect#primary_key}
        /// </remarks>
        [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey? PrimaryKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCrossConnectMacsecProperties), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectMacsecProperties")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCrossConnect.ICoreCrossConnectMacsecProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#state CoreCrossConnect#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#encryption_cipher CoreCrossConnect#encryption_cipher}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionCipher
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#is_unprotected_traffic_allowed CoreCrossConnect#is_unprotected_traffic_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isUnprotectedTrafficAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUnprotectedTrafficAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>primary_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#primary_key CoreCrossConnect#primary_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey\"}", isOptional: true)]
            public oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey? PrimaryKey
            {
                get => GetInstanceProperty<oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey?>();
            }
        }
    }
}
