using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDemandSignalOccMetricAlarm
{
    [JsiiClass(nativeType: typeof(oci.DataOciDemandSignalOccMetricAlarm.DataOciDemandSignalOccMetricAlarmResourceConfigurationOutputReference), fullyQualifiedName: "oci.dataOciDemandSignalOccMetricAlarm.DataOciDemandSignalOccMetricAlarmResourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDemandSignalOccMetricAlarmResourceConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDemandSignalOccMetricAlarmResourceConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDemandSignalOccMetricAlarmResourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDemandSignalOccMetricAlarmResourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "computeHwGeneration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeHwGeneration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hwGeneration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HwGeneration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linkRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "occMetricAlarmProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OccMetricAlarmProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDemandSignalOccMetricAlarm.DataOciDemandSignalOccMetricAlarmResourceConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciDemandSignalOccMetricAlarm.IDataOciDemandSignalOccMetricAlarmResourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDemandSignalOccMetricAlarm.IDataOciDemandSignalOccMetricAlarmResourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
