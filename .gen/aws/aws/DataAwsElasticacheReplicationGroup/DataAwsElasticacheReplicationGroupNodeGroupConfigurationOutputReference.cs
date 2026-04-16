using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheReplicationGroup
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroupNodeGroupConfigurationOutputReference), fullyQualifiedName: "aws.dataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroupNodeGroupConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsElasticacheReplicationGroupNodeGroupConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsElasticacheReplicationGroupNodeGroupConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsElasticacheReplicationGroupNodeGroupConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticacheReplicationGroupNodeGroupConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "nodeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryAvailabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryOutpostArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryOutpostArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicaAvailabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReplicaAvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicaOutpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReplicaOutpostArns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "slots", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Slots
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsElasticacheReplicationGroup.DataAwsElasticacheReplicationGroupNodeGroupConfiguration\"}", isOptional: true)]
        public virtual aws.DataAwsElasticacheReplicationGroup.IDataAwsElasticacheReplicationGroupNodeGroupConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsElasticacheReplicationGroup.IDataAwsElasticacheReplicationGroupNodeGroupConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
