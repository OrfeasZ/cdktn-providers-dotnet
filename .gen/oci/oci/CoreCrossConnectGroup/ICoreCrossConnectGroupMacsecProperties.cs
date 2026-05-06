using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnectGroup
{
    [JsiiInterface(nativeType: typeof(ICoreCrossConnectGroupMacsecProperties), fullyQualifiedName: "oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecProperties")]
    public interface ICoreCrossConnectGroupMacsecProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#state CoreCrossConnectGroup#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#encryption_cipher CoreCrossConnectGroup#encryption_cipher}.</summary>
        [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionCipher
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#is_unprotected_traffic_allowed CoreCrossConnectGroup#is_unprotected_traffic_allowed}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#primary_key CoreCrossConnectGroup#primary_key}
        /// </remarks>
        [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecPropertiesPrimaryKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecPropertiesPrimaryKey? PrimaryKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCrossConnectGroupMacsecProperties), fullyQualifiedName: "oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecProperties")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#state CoreCrossConnectGroup#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#encryption_cipher CoreCrossConnectGroup#encryption_cipher}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionCipher
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#is_unprotected_traffic_allowed CoreCrossConnectGroup#is_unprotected_traffic_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isUnprotectedTrafficAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsUnprotectedTrafficAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>primary_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#primary_key CoreCrossConnectGroup#primary_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryKey", typeJson: "{\"fqn\":\"oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecPropertiesPrimaryKey\"}", isOptional: true)]
            public oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecPropertiesPrimaryKey? PrimaryKey
            {
                get => GetInstanceProperty<oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecPropertiesPrimaryKey?>();
            }
        }
    }
}
