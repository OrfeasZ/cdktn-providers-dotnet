using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackDataflowDriverShapeConfig), fullyQualifiedName: "oci.difStack.DifStackDataflowDriverShapeConfig")]
    public interface IDifStackDataflowDriverShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#memory_in_gbs DifStack#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#ocpus DifStack#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        double Ocpus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackDataflowDriverShapeConfig), fullyQualifiedName: "oci.difStack.DifStackDataflowDriverShapeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackDataflowDriverShapeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#memory_in_gbs DifStack#memory_in_gbs}.</summary>
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/dif_stack#ocpus DifStack#ocpus}.</summary>
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
            public double Ocpus
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
