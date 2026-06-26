using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Datalab
{
    [JsiiInterface(nativeType: typeof(IDatalabTotalStorage), fullyQualifiedName: "scaleway.datalab.DatalabTotalStorage")]
    public interface IDatalabTotalStorage
    {
        /// <summary>The volume size in bytes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.77.1/docs/resources/datalab#size Datalab#size}
        /// </remarks>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        /// <summary>The volume type. Defaults to `sbs_5k`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.77.1/docs/resources/datalab#type Datalab#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatalabTotalStorage), fullyQualifiedName: "scaleway.datalab.DatalabTotalStorage")]
        internal sealed class _Proxy : DeputyBase, scaleway.Datalab.IDatalabTotalStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The volume size in bytes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.77.1/docs/resources/datalab#size Datalab#size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The volume type. Defaults to `sbs_5k`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.77.1/docs/resources/datalab#type Datalab#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
