using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eksNodeGroup.EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides")]
    public class EksNodeGroupNodeRepairConfigNodeRepairConfigOverrides : aws.EksNodeGroup.IEksNodeGroupNodeRepairConfigNodeRepairConfigOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_node_group#min_repair_wait_time_mins EksNodeGroup#min_repair_wait_time_mins}.</summary>
        [JsiiProperty(name: "minRepairWaitTimeMins", typeJson: "{\"primitive\":\"number\"}")]
        public double MinRepairWaitTimeMins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_node_group#node_monitoring_condition EksNodeGroup#node_monitoring_condition}.</summary>
        [JsiiProperty(name: "nodeMonitoringCondition", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeMonitoringCondition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_node_group#node_unhealthy_reason EksNodeGroup#node_unhealthy_reason}.</summary>
        [JsiiProperty(name: "nodeUnhealthyReason", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeUnhealthyReason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_node_group#repair_action EksNodeGroup#repair_action}.</summary>
        [JsiiProperty(name: "repairAction", typeJson: "{\"primitive\":\"string\"}")]
        public string RepairAction
        {
            get;
            set;
        }
    }
}
