using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterOutpostConfig), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfig")]
    public interface IEksClusterOutpostConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#control_plane_instance_type EksCluster#control_plane_instance_type}.</summary>
        [JsiiProperty(name: "controlPlaneInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        string ControlPlaneInstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#outpost_arns EksCluster#outpost_arns}.</summary>
        [JsiiProperty(name: "outpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] OutpostArns
        {
            get;
        }

        /// <summary>control_plane_placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#control_plane_placement EksCluster#control_plane_placement}
        /// </remarks>
        [JsiiProperty(name: "controlPlanePlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement? ControlPlanePlacement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#etcd_instance_type EksCluster#etcd_instance_type}.</summary>
        [JsiiProperty(name: "etcdInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EtcdInstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>etcd_placement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#etcd_placement EksCluster#etcd_placement}
        /// </remarks>
        [JsiiProperty(name: "etcdPlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigEtcdPlacement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement? EtcdPlacement
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterOutpostConfig), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterOutpostConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#control_plane_instance_type EksCluster#control_plane_instance_type}.</summary>
            [JsiiProperty(name: "controlPlaneInstanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ControlPlaneInstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#outpost_arns EksCluster#outpost_arns}.</summary>
            [JsiiProperty(name: "outpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] OutpostArns
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>control_plane_placement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#control_plane_placement EksCluster#control_plane_placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controlPlanePlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement? ControlPlanePlacement
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#etcd_instance_type EksCluster#etcd_instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "etcdInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EtcdInstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>etcd_placement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.51.0/docs/resources/eks_cluster#etcd_placement EksCluster#etcd_placement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "etcdPlacement", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterOutpostConfigEtcdPlacement\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement? EtcdPlacement
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterOutpostConfigEtcdPlacement?>();
            }
        }
    }
}
