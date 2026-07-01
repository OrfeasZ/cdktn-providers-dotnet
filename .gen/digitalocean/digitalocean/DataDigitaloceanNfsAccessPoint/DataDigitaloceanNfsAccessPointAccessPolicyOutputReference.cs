using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanNfsAccessPoint
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanNfsAccessPoint.DataDigitaloceanNfsAccessPointAccessPolicyOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanNfsAccessPoint.DataDigitaloceanNfsAccessPointAccessPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanNfsAccessPointAccessPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanNfsAccessPointAccessPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanNfsAccessPointAccessPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanNfsAccessPointAccessPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "anongid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Anongid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "anonuid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Anonuid
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "identityEnforcementEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdentityEnforcementEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "squashConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SquashConfig
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanNfsAccessPoint.DataDigitaloceanNfsAccessPointAccessPolicy\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanNfsAccessPoint.IDataDigitaloceanNfsAccessPointAccessPolicy? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanNfsAccessPoint.IDataDigitaloceanNfsAccessPointAccessPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
