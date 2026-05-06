using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiInterface(nativeType: typeof(IGoldenGateDeploymentOggDataGroupToRolesMapping), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping")]
    public interface IGoldenGateDeploymentOggDataGroupToRolesMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#security_group_id GoldenGateDeployment#security_group_id}.</summary>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#administrator_group_id GoldenGateDeployment#administrator_group_id}.</summary>
        [JsiiProperty(name: "administratorGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdministratorGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#operator_group_id GoldenGateDeployment#operator_group_id}.</summary>
        [JsiiProperty(name: "operatorGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatorGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#user_group_id GoldenGateDeployment#user_group_id}.</summary>
        [JsiiProperty(name: "userGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateDeploymentOggDataGroupToRolesMapping), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentOggDataGroupToRolesMapping")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateDeployment.IGoldenGateDeploymentOggDataGroupToRolesMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#security_group_id GoldenGateDeployment#security_group_id}.</summary>
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#administrator_group_id GoldenGateDeployment#administrator_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "administratorGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdministratorGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#operator_group_id GoldenGateDeployment#operator_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatorGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatorGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#user_group_id GoldenGateDeployment#user_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
