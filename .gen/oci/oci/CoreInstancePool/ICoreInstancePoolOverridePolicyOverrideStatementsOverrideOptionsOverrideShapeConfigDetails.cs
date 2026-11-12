using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiInterface(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails")]
    public interface ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#baseline_ocpu_utilization CoreInstancePool#baseline_ocpu_utilization}.</summary>
        [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaselineOcpuUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#local_volume_size_in_gbs CoreInstancePool#local_volume_size_in_gbs}.</summary>
        [JsiiProperty(name: "localVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LocalVolumeSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#memory_in_gbs CoreInstancePool#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#nvmes CoreInstancePool#nvmes}.</summary>
        [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Nvmes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#ocpus CoreInstancePool#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ocpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#resource_management CoreInstancePool#resource_management}.</summary>
        [JsiiProperty(name: "resourceManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#vcpus CoreInstancePool#vcpus}.</summary>
        [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vcpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#baseline_ocpu_utilization CoreInstancePool#baseline_ocpu_utilization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaselineOcpuUtilization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#local_volume_size_in_gbs CoreInstancePool#local_volume_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localVolumeSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LocalVolumeSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#memory_in_gbs CoreInstancePool#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#nvmes CoreInstancePool#nvmes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nvmes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Nvmes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#ocpus CoreInstancePool#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ocpus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#resource_management CoreInstancePool#resource_management}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceManagement
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/core_instance_pool#vcpus CoreInstancePool#vcpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vcpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
