using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainOsn
{
    [JsiiClass(nativeType: typeof(oci.BlockchainOsn.BlockchainOsnOcpuAllocationParamOutputReference), fullyQualifiedName: "oci.blockchainOsn.BlockchainOsnOcpuAllocationParamOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BlockchainOsnOcpuAllocationParamOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BlockchainOsnOcpuAllocationParamOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BlockchainOsnOcpuAllocationParamOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BlockchainOsnOcpuAllocationParamOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpuAllocationNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpuAllocationNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "ocpuAllocationNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuAllocationNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.blockchainOsn.BlockchainOsnOcpuAllocationParam\"}", isOptional: true)]
        public virtual oci.BlockchainOsn.IBlockchainOsnOcpuAllocationParam? InternalValue
        {
            get => GetInstanceProperty<oci.BlockchainOsn.IBlockchainOsnOcpuAllocationParam?>();
            set => SetInstanceProperty(value);
        }
    }
}
