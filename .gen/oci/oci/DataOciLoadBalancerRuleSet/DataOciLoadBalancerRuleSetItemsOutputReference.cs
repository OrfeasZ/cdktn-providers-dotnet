using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoadBalancerRuleSet
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsOutputReference), fullyQualifiedName: "oci.dataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoadBalancerRuleSetItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoadBalancerRuleSetItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoadBalancerRuleSetItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoadBalancerRuleSetItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedMethods
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "areInvalidCharactersAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreInvalidCharactersAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsConditionsList\"}")]
        public virtual oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsConditionsList Conditions
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsConditionsList>()!;
        }

        [JsiiProperty(name: "defaultMaxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultMaxConnections
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Header
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpLargeHeaderSizeInKb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpLargeHeaderSizeInKb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ipMaxConnections", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsIpMaxConnectionsList\"}")]
        public virtual oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsIpMaxConnectionsList IpMaxConnections
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsIpMaxConnectionsList>()!;
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUri", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsRedirectUriList\"}")]
        public virtual oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsRedirectUriList RedirectUri
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItemsRedirectUriList>()!;
        }

        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponseCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StatusCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Suffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerRuleSet.DataOciLoadBalancerRuleSetItems\"}", isOptional: true)]
        public virtual oci.DataOciLoadBalancerRuleSet.IDataOciLoadBalancerRuleSetItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerRuleSet.IDataOciLoadBalancerRuleSetItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
