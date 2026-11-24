using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HorizondbCluster.HorizondbClusterReadWritePoolOutputReference), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterReadWritePoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HorizondbClusterReadWritePoolOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HorizondbClusterReadWritePoolOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HorizondbClusterReadWritePoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HorizondbClusterReadWritePoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute\"}}]")]
        public virtual void PutCompute(azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute)}, new object[]{@value});
        }

        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolComputeOutputReference\"}")]
        public virtual azurerm.HorizondbCluster.HorizondbClusterReadWritePoolComputeOutputReference Compute
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.HorizondbClusterReadWritePoolComputeOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeInput", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePoolCompute\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute? ComputeInput
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterReadWritePoolCompute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "highAvailabilityModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HighAvailabilityModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "highAvailabilityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HighAvailabilityMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterReadWritePool\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterReadWritePool? InternalValue
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterReadWritePool?>();
            set => SetInstanceProperty(value);
        }
    }
}
