using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeGpuMemoryFabric
{
    [JsiiClass(nativeType: typeof(oci.CoreComputeGpuMemoryFabric.CoreComputeGpuMemoryFabricMemoryFabricPreferencesOutputReference), fullyQualifiedName: "oci.coreComputeGpuMemoryFabric.CoreComputeGpuMemoryFabricMemoryFabricPreferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreComputeGpuMemoryFabricMemoryFabricPreferencesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreComputeGpuMemoryFabricMemoryFabricPreferencesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreComputeGpuMemoryFabricMemoryFabricPreferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreComputeGpuMemoryFabricMemoryFabricPreferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomerDesiredFirmwareBundleId")]
        public virtual void ResetCustomerDesiredFirmwareBundleId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFabricRecycleLevel")]
        public virtual void ResetFabricRecycleLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerDesiredFirmwareBundleIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerDesiredFirmwareBundleIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fabricRecycleLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FabricRecycleLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customerDesiredFirmwareBundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerDesiredFirmwareBundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fabricRecycleLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FabricRecycleLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreComputeGpuMemoryFabric.CoreComputeGpuMemoryFabricMemoryFabricPreferences\"}", isOptional: true)]
        public virtual oci.CoreComputeGpuMemoryFabric.ICoreComputeGpuMemoryFabricMemoryFabricPreferences? InternalValue
        {
            get => GetInstanceProperty<oci.CoreComputeGpuMemoryFabric.ICoreComputeGpuMemoryFabricMemoryFabricPreferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
