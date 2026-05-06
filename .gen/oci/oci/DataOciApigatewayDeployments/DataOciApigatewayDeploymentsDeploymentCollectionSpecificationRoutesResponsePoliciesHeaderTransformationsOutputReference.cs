using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApigatewayDeployments
{
    [JsiiClass(nativeType: typeof(oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference), fullyQualifiedName: "oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeadersList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeadersList FilterHeaders
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsFilterHeadersList>()!;
        }

        [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersList RenameHeaders
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersList>()!;
        }

        [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeadersList\"}")]
        public virtual oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeadersList SetHeaders
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformationsSetHeadersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApigatewayDeployments.DataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformations\"}", isOptional: true)]
        public virtual oci.DataOciApigatewayDeployments.IDataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformations? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApigatewayDeployments.IDataOciApigatewayDeploymentsDeploymentCollectionSpecificationRoutesResponsePoliciesHeaderTransformations?>();
            set => SetInstanceProperty(value);
        }
    }
}
