using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReport
{
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReport.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecksOutputReference), fullyQualifiedName: "oci.dataOciGoldenGateDeploymentDisasterRecoveryPrecheckReport.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Code
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "correctiveAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorrectiveAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelatedResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciGoldenGateDeploymentDisasterRecoveryPrecheckReport.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecks\"}", isOptional: true)]
        public virtual oci.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReport.IDataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecks? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciGoldenGateDeploymentDisasterRecoveryPrecheckReport.IDataOciGoldenGateDeploymentDisasterRecoveryPrecheckReportChecks?>();
            set => SetInstanceProperty(value);
        }
    }
}
