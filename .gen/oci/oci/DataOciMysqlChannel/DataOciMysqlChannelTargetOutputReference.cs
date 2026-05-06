using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlChannel
{
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlChannel.DataOciMysqlChannelTargetOutputReference), fullyQualifiedName: "oci.dataOciMysqlChannel.DataOciMysqlChannelTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMysqlChannelTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMysqlChannelTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMysqlChannelTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlChannelTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applierUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplierUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "channelName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChannelName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "delayInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DelayInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"oci.dataOciMysqlChannel.DataOciMysqlChannelTargetFiltersList\"}")]
        public virtual oci.DataOciMysqlChannel.DataOciMysqlChannelTargetFiltersList Filters
        {
            get => GetInstanceProperty<oci.DataOciMysqlChannel.DataOciMysqlChannelTargetFiltersList>()!;
        }

        [JsiiProperty(name: "tablesWithoutPrimaryKeyHandling", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TablesWithoutPrimaryKeyHandling
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMysqlChannel.DataOciMysqlChannelTarget\"}", isOptional: true)]
        public virtual oci.DataOciMysqlChannel.IDataOciMysqlChannelTarget? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMysqlChannel.IDataOciMysqlChannelTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
