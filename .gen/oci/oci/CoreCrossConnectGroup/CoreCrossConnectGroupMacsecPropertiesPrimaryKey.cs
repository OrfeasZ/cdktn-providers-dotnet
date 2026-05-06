using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCrossConnectGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreCrossConnectGroup.CoreCrossConnectGroupMacsecPropertiesPrimaryKey")]
    public class CoreCrossConnectGroupMacsecPropertiesPrimaryKey : oci.CoreCrossConnectGroup.ICoreCrossConnectGroupMacsecPropertiesPrimaryKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#connectivity_association_key_secret_id CoreCrossConnectGroup#connectivity_association_key_secret_id}.</summary>
        [JsiiProperty(name: "connectivityAssociationKeySecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectivityAssociationKeySecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#connectivity_association_name_secret_id CoreCrossConnectGroup#connectivity_association_name_secret_id}.</summary>
        [JsiiProperty(name: "connectivityAssociationNameSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectivityAssociationNameSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#connectivity_association_key_secret_version CoreCrossConnectGroup#connectivity_association_key_secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectivityAssociationKeySecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectivityAssociationKeySecretVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_cross_connect_group#connectivity_association_name_secret_version CoreCrossConnectGroup#connectivity_association_name_secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectivityAssociationNameSecretVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectivityAssociationNameSecretVersion
        {
            get;
            set;
        }
    }
}
