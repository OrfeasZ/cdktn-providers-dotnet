using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides")]
    public interface IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#min_repair_wait_time_mins EksNodeGroup#min_repair_wait_time_mins}.</summary>
        [JsiiProperty(name: "minRepairWaitTimeMins", typeJson: "{\"primitive\":\"number\"}")]
        double MinRepairWaitTimeMins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#node_monitoring_condition EksNodeGroup#node_monitoring_condition}.</summary>
        [JsiiProperty(name: "nodeMonitoringCondition", typeJson: "{\"primitive\":\"string\"}")]
        string NodeMonitoringCondition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#node_unhealthy_reason EksNodeGroup#node_unhealthy_reason}.</summary>
        [JsiiProperty(name: "nodeUnhealthyReason", typeJson: "{\"primitive\":\"string\"}")]
        string NodeUnhealthyReason
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#repair_action EksNodeGroup#repair_action}.</summary>
        [JsiiProperty(name: "repairAction", typeJson: "{\"primitive\":\"string\"}")]
        string RepairAction
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides")]
        internal sealed class _Proxy : DeputyBase, aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#min_repair_wait_time_mins EksNodeGroup#min_repair_wait_time_mins}.</summary>
            [JsiiProperty(name: "minRepairWaitTimeMins", typeJson: "{\"primitive\":\"number\"}")]
            public double MinRepairWaitTimeMins
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#node_monitoring_condition EksNodeGroup#node_monitoring_condition}.</summary>
            [JsiiProperty(name: "nodeMonitoringCondition", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeMonitoringCondition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#node_unhealthy_reason EksNodeGroup#node_unhealthy_reason}.</summary>
            [JsiiProperty(name: "nodeUnhealthyReason", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeUnhealthyReason
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/eks_node_group#repair_action EksNodeGroup#repair_action}.</summary>
            [JsiiProperty(name: "repairAction", typeJson: "{\"primitive\":\"string\"}")]
            public string RepairAction
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
