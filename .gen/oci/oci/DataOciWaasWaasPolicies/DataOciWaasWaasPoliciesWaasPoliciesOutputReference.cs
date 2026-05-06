using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPoliciesWaasPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPoliciesWaasPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPoliciesWaasPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPoliciesWaasPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalDomains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originGroups", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOriginGroupsList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOriginGroupsList OriginGroups
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOriginGroupsList>()!;
        }

        [JsiiProperty(name: "origins", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOriginsList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOriginsList Origins
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesOriginsList>()!;
        }

        [JsiiProperty(name: "policyConfig", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigList PolicyConfig
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesPolicyConfigList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "wafConfig", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigList\"}")]
        public virtual oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigList WafConfig
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPoliciesWafConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicies.DataOciWaasWaasPoliciesWaasPolicies\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPolicies? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicies.IDataOciWaasWaasPoliciesWaasPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}
