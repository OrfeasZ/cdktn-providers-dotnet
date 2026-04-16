using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareDnsRecord
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareDnsRecord.DataCloudflareDnsRecordDataOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareDnsRecordDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareDnsRecordDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareDnsRecordDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareDnsRecordDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Algorithm
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "altitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Altitude
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Digest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "digestType", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DigestType
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flags", typeJson: "{\"fqn\":\"cdktn.AnyMap\"}")]
        public virtual Io.Cdktn.AnyMap Flags
        {
            get => GetInstanceProperty<Io.Cdktn.AnyMap>()!;
        }

        [JsiiProperty(name: "keyTag", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeyTag
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "latDegrees", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatDegrees
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "latDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LatDirection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "latSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "longDegrees", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LongDegrees
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "longDirection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LongDirection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "longMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LongMinutes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "longSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LongSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "matchingType", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MatchingType
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "precisionHorz", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrecisionHorz
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "precisionVert", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrecisionVert
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Preference
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Protocol
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Regex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replacement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Replacement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Selector
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Service
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Target
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Type
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Usage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareDnsRecord.DataCloudflareDnsRecordData\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordData? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareDnsRecord.IDataCloudflareDnsRecordData?>();
            set => SetInstanceProperty(value);
        }
    }
}
