using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DemandSignalOccMetricAlarm
{
    [JsiiClass(nativeType: typeof(oci.DemandSignalOccMetricAlarm.DemandSignalOccMetricAlarmResourceConfigurationOutputReference), fullyQualifiedName: "oci.demandSignalOccMetricAlarm.DemandSignalOccMetricAlarmResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DemandSignalOccMetricAlarmResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DemandSignalOccMetricAlarmResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DemandSignalOccMetricAlarmResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DemandSignalOccMetricAlarmResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputeHwGeneration")]
        public virtual void ResetComputeHwGeneration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHwGeneration")]
        public virtual void ResetHwGeneration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinkRole")]
        public virtual void ResetLinkRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeType")]
        public virtual void ResetNodeType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOccMetricAlarmProvider")]
        public virtual void ResetOccMetricAlarmProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShape")]
        public virtual void ResetShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageType")]
        public virtual void ResetStorageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeHwGenerationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeHwGenerationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hwGenerationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HwGenerationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LinkRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "occMetricAlarmProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OccMetricAlarmProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "computeHwGeneration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeHwGeneration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hwGeneration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HwGeneration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "linkRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "occMetricAlarmProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OccMetricAlarmProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.demandSignalOccMetricAlarm.DemandSignalOccMetricAlarmResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DemandSignalOccMetricAlarm.IDemandSignalOccMetricAlarmResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DemandSignalOccMetricAlarm.IDemandSignalOccMetricAlarmResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
