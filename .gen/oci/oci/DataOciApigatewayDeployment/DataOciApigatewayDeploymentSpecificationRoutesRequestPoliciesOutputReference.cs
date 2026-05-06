using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApigatewayDeployment
{
    [JsiiClass(nativeType: typeof(oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesOutputReference), fullyQualifiedName: "oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesAuthorizationList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesAuthorizationList Authorization
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesAuthorizationList>()!;
        }

        [JsiiProperty(name: "bodyValidation", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationList BodyValidation
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationList>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesCorsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesCorsList Cors
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesCorsList>()!;
        }

        [JsiiProperty(name: "headerTransformations", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsList HeaderTransformations
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsList>()!;
        }

        [JsiiProperty(name: "headerValidations", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderValidationsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderValidationsList HeaderValidations
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderValidationsList>()!;
        }

        [JsiiProperty(name: "queryParameterTransformations", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsList QueryParameterTransformations
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsList>()!;
        }

        [JsiiProperty(name: "queryParameterValidations", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterValidationsList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterValidationsList QueryParameterValidations
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterValidationsList>()!;
        }

        [JsiiProperty(name: "responseCacheLookup", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesResponseCacheLookupList\"}")]
        public virtual oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesResponseCacheLookupList ResponseCacheLookup
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPoliciesResponseCacheLookupList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployment.DataOciApigatewayDeploymentSpecificationRoutesRequestPolicies\"}", isOptional: true)]
        public virtual oci.DataOciApigatewayDeployment.IDataOciApigatewayDeploymentSpecificationRoutesRequestPolicies? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployment.IDataOciApigatewayDeploymentSpecificationRoutesRequestPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}
