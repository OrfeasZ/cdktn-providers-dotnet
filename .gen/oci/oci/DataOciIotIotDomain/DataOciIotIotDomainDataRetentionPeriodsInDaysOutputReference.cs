using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIotIotDomain
{
    [JsiiClass(nativeType: typeof(oci.DataOciIotIotDomain.DataOciIotIotDomainDataRetentionPeriodsInDaysOutputReference), fullyQualifiedName: "oci.dataOciIotIotDomain.DataOciIotIotDomainDataRetentionPeriodsInDaysOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIotIotDomainDataRetentionPeriodsInDaysOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIotIotDomainDataRetentionPeriodsInDaysOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIotIotDomainDataRetentionPeriodsInDaysOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIotIotDomainDataRetentionPeriodsInDaysOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "historizedData", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HistorizedData
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rawCommandData", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RawCommandData
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rawData", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RawData
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rejectedData", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RejectedData
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIotIotDomain.DataOciIotIotDomainDataRetentionPeriodsInDays\"}", isOptional: true)]
        public virtual oci.DataOciIotIotDomain.IDataOciIotIotDomainDataRetentionPeriodsInDays? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIotIotDomain.IDataOciIotIotDomainDataRetentionPeriodsInDays?>();
            set => SetInstanceProperty(value);
        }
    }
}
