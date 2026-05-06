using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnect
{
    [JsiiInterface(nativeType: typeof(ICoreCrossConnectMacsecPropertiesPrimaryKey), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey")]
    public interface ICoreCrossConnectMacsecPropertiesPrimaryKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_key_secret_id CoreCrossConnect#connectivity_association_key_secret_id}.</summary>
        [JsiiProperty(name: "connectivityAssociationKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectivityAssociationKeySecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_name_secret_id CoreCrossConnect#connectivity_association_name_secret_id}.</summary>
        [JsiiProperty(name: "connectivityAssociationNameSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectivityAssociationNameSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_key_secret_version CoreCrossConnect#connectivity_association_key_secret_version}.</summary>
        [JsiiProperty(name: "connectivityAssociationKeySecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectivityAssociationKeySecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_name_secret_version CoreCrossConnect#connectivity_association_name_secret_version}.</summary>
        [JsiiProperty(name: "connectivityAssociationNameSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectivityAssociationNameSecretVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCrossConnectMacsecPropertiesPrimaryKey), fullyQualifiedName: "oci.coreCrossConnect.CoreCrossConnectMacsecPropertiesPrimaryKey")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCrossConnect.ICoreCrossConnectMacsecPropertiesPrimaryKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_key_secret_id CoreCrossConnect#connectivity_association_key_secret_id}.</summary>
            [JsiiProperty(name: "connectivityAssociationKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectivityAssociationKeySecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_name_secret_id CoreCrossConnect#connectivity_association_name_secret_id}.</summary>
            [JsiiProperty(name: "connectivityAssociationNameSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectivityAssociationNameSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_key_secret_version CoreCrossConnect#connectivity_association_key_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectivityAssociationKeySecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectivityAssociationKeySecretVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect#connectivity_association_name_secret_version CoreCrossConnect#connectivity_association_name_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectivityAssociationNameSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectivityAssociationNameSecretVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
