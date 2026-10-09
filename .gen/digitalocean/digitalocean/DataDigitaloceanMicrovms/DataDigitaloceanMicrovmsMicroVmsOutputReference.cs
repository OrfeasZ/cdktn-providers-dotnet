using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanMicrovms
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanMicrovmsMicroVmsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanMicrovmsMicroVmsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanMicrovmsMicroVmsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanMicrovmsMicroVmsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoPause", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsAutoPauseList\"}")]
        public virtual digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsAutoPauseList AutoPause
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsAutoPauseList>()!;
        }

        [JsiiProperty(name: "autoResume", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoResume
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Environment
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "failureReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networking", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Networking
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Ports
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsSizeList\"}")]
        public virtual digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsSizeList Size
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsSizeList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsSourceList\"}")]
        public virtual digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsSourceList Source
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "urls", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsUrlsList\"}")]
        public virtual digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsUrlsList Urls
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVmsUrlsList>()!;
        }

        [JsiiProperty(name: "urn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Urn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanMicrovms.DataDigitaloceanMicrovmsMicroVms\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanMicrovms.IDataDigitaloceanMicrovmsMicroVms? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanMicrovms.IDataDigitaloceanMicrovmsMicroVms?>();
            set => SetInstanceProperty(value);
        }
    }
}
