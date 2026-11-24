using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HorizondbCluster.HorizondbClusterReadWritePoolComputeOutputReference), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterReadWritePoolComputeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HorizondbClusterReadWritePoolComputeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HorizondbClusterReadWritePoolComputeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HorizondbClusterReadWritePoolComputeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HorizondbClusterReadWritePoolComputeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "generationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GenerationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProcessorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcoresInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VcoresInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Generation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "processor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Processor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcores", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vcores
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute? InternalValue
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute?>();
            set => SetInstanceProperty(value);
        }
    }
}
