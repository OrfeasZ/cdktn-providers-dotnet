using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BlockchainBlockchainPlatform
{
    [JsiiClass(nativeType: typeof(oci.BlockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicasOutputReference), fullyQualifiedName: "oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicasOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BlockchainBlockchainPlatformReplicasOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BlockchainBlockchainPlatformReplicasOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BlockchainBlockchainPlatformReplicasOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BlockchainBlockchainPlatformReplicasOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCaCount")]
        public virtual void ResetCaCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConsoleCount")]
        public virtual void ResetConsoleCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyCount")]
        public virtual void ResetProxyCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "caCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CaCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "consoleCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConsoleCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProxyCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "caCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CaCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "consoleCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConsoleCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proxyCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProxyCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.blockchainBlockchainPlatform.BlockchainBlockchainPlatformReplicas\"}", isOptional: true)]
        public virtual oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas? InternalValue
        {
            get => GetInstanceProperty<oci.BlockchainBlockchainPlatform.IBlockchainBlockchainPlatformReplicas?>();
            set => SetInstanceProperty(value);
        }
    }
}
