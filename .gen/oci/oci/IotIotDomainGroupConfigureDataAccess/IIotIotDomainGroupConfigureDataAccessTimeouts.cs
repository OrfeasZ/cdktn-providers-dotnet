using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotDomainGroupConfigureDataAccess
{
    [JsiiInterface(nativeType: typeof(IIotIotDomainGroupConfigureDataAccessTimeouts), fullyQualifiedName: "oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeouts")]
    public interface IIotIotDomainGroupConfigureDataAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_group_configure_data_access#create IotIotDomainGroupConfigureDataAccess#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_group_configure_data_access#delete IotIotDomainGroupConfigureDataAccess#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_group_configure_data_access#update IotIotDomainGroupConfigureDataAccess#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIotDomainGroupConfigureDataAccessTimeouts), fullyQualifiedName: "oci.iotIotDomainGroupConfigureDataAccess.IotIotDomainGroupConfigureDataAccessTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IotIotDomainGroupConfigureDataAccess.IIotIotDomainGroupConfigureDataAccessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_group_configure_data_access#create IotIotDomainGroupConfigureDataAccess#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_group_configure_data_access#delete IotIotDomainGroupConfigureDataAccess#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/iot_iot_domain_group_configure_data_access#update IotIotDomainGroupConfigureDataAccess#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
