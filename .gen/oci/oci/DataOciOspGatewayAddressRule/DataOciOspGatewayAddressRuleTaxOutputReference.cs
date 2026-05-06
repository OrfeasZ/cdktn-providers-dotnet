using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewayAddressRule
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxOutputReference), fullyQualifiedName: "oci.dataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewayAddressRuleTaxOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewayAddressRuleTaxOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewayAddressRuleTaxOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewayAddressRuleTaxOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fields", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxFieldsList\"}")]
        public virtual oci.DataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxFieldsList Fields
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxFieldsList>()!;
        }

        [JsiiProperty(name: "valueSet", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxValueSetList\"}")]
        public virtual oci.DataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxValueSetList ValueSet
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTaxValueSetList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayAddressRule.DataOciOspGatewayAddressRuleTax\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewayAddressRule.IDataOciOspGatewayAddressRuleTax? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayAddressRule.IDataOciOspGatewayAddressRuleTax?>();
            set => SetInstanceProperty(value);
        }
    }
}
