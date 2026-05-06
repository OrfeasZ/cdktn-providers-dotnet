using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetCryptoAnalysisResults
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aggregationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AggregationMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cryptoRoadmapVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CryptoRoadmapVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "findingCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FindingCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonCompliantFindingCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NonCompliantFindingCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "summarizedEventCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SummarizedEventCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFirstEvent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFirstEvent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastEvent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastEvent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalEventCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalEventCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetCryptoAnalysisResults.DataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetCryptoAnalysisResults.IDataOciJmsFleetCryptoAnalysisResultsCryptoAnalysisResultCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
