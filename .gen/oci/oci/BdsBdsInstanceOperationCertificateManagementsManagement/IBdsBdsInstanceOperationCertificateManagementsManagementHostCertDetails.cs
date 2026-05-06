using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceOperationCertificateManagementsManagement
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails), fullyQualifiedName: "oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails")]
    public interface IBdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#certificate BdsBdsInstanceOperationCertificateManagementsManagement#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#host_name BdsBdsInstanceOperationCertificateManagementsManagement#host_name}.</summary>
        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#private_key BdsBdsInstanceOperationCertificateManagementsManagement#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails), fullyQualifiedName: "oci.bdsBdsInstanceOperationCertificateManagementsManagement.BdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceOperationCertificateManagementsManagement.IBdsBdsInstanceOperationCertificateManagementsManagementHostCertDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#certificate BdsBdsInstanceOperationCertificateManagementsManagement#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#host_name BdsBdsInstanceOperationCertificateManagementsManagement#host_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_operation_certificate_managements_management#private_key BdsBdsInstanceOperationCertificateManagementsManagement#private_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
