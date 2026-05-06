using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringProcessSet
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringProcessSet.DataOciStackMonitoringProcessSetSpecificationItemsOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringProcessSet.DataOciStackMonitoringProcessSetSpecificationItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringProcessSetSpecificationItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringProcessSetSpecificationItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringProcessSetSpecificationItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringProcessSetSpecificationItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Label
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessCommand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processLineRegexPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessLineRegexPattern
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "processUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringProcessSet.DataOciStackMonitoringProcessSetSpecificationItems\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringProcessSet.IDataOciStackMonitoringProcessSetSpecificationItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringProcessSet.IDataOciStackMonitoringProcessSetSpecificationItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
