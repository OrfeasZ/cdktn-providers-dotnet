using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BastionSession
{
    [JsiiInterface(nativeType: typeof(IBastionSessionTargetResourceDetails), fullyQualifiedName: "oci.bastionSession.BastionSessionTargetResourceDetails")]
    public interface IBastionSessionTargetResourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#session_type BastionSession#session_type}.</summary>
        [JsiiProperty(name: "sessionType", typeJson: "{\"primitive\":\"string\"}")]
        string SessionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_fqdn BastionSession#target_resource_fqdn}.</summary>
        [JsiiProperty(name: "targetResourceFqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetResourceFqdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_id BastionSession#target_resource_id}.</summary>
        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_operating_system_user_name BastionSession#target_resource_operating_system_user_name}.</summary>
        [JsiiProperty(name: "targetResourceOperatingSystemUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetResourceOperatingSystemUserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_port BastionSession#target_resource_port}.</summary>
        [JsiiProperty(name: "targetResourcePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetResourcePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_private_ip_address BastionSession#target_resource_private_ip_address}.</summary>
        [JsiiProperty(name: "targetResourcePrivateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetResourcePrivateIpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBastionSessionTargetResourceDetails), fullyQualifiedName: "oci.bastionSession.BastionSessionTargetResourceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BastionSession.IBastionSessionTargetResourceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#session_type BastionSession#session_type}.</summary>
            [JsiiProperty(name: "sessionType", typeJson: "{\"primitive\":\"string\"}")]
            public string SessionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_fqdn BastionSession#target_resource_fqdn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourceFqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetResourceFqdn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_id BastionSession#target_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_operating_system_user_name BastionSession#target_resource_operating_system_user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourceOperatingSystemUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetResourceOperatingSystemUserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_port BastionSession#target_resource_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourcePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetResourcePort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_private_ip_address BastionSession#target_resource_private_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetResourcePrivateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetResourcePrivateIpAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
