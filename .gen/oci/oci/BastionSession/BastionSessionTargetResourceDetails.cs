using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BastionSession
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bastionSession.BastionSessionTargetResourceDetails")]
    public class BastionSessionTargetResourceDetails : oci.BastionSession.IBastionSessionTargetResourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#session_type BastionSession#session_type}.</summary>
        [JsiiProperty(name: "sessionType", typeJson: "{\"primitive\":\"string\"}")]
        public string SessionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_fqdn BastionSession#target_resource_fqdn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceFqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourceFqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_id BastionSession#target_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_operating_system_user_name BastionSession#target_resource_operating_system_user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourceOperatingSystemUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourceOperatingSystemUserName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_port BastionSession#target_resource_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourcePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetResourcePort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bastion_session#target_resource_private_ip_address BastionSession#target_resource_private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetResourcePrivateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetResourcePrivateIpAddress
        {
            get;
            set;
        }
    }
}
