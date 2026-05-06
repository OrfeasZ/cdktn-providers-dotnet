using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping")]
    public class GoldenGateDeploymentOggDataGroupToRolesMapping : oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#security_group_id GoldenGateDeployment#security_group_id}.</summary>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string SecurityGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#administrator_group_id GoldenGateDeployment#administrator_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "administratorGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdministratorGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#operator_group_id GoldenGateDeployment#operator_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatorGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatorGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#user_group_id GoldenGateDeployment#user_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserGroupId
        {
            get;
            set;
        }
    }
}
