using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsBuildRun
{
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsOutputReference), fullyQualifiedName: "oci.dataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDevopsBuildRunBuildOutputsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDevopsBuildRunBuildOutputsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDevopsBuildRunBuildOutputsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsBuildRunBuildOutputsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "artifactOverrideParameters", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsArtifactOverrideParametersList\"}")]
        public virtual oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsArtifactOverrideParametersList ArtifactOverrideParameters
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsArtifactOverrideParametersList>()!;
        }

        [JsiiProperty(name: "deliveredArtifacts", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsDeliveredArtifactsList\"}")]
        public virtual oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsDeliveredArtifactsList DeliveredArtifacts
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsDeliveredArtifactsList>()!;
        }

        [JsiiProperty(name: "exportedVariables", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsExportedVariablesList\"}")]
        public virtual oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsExportedVariablesList ExportedVariables
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsExportedVariablesList>()!;
        }

        [JsiiProperty(name: "vulnerabilityAuditSummaryCollection", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsVulnerabilityAuditSummaryCollectionList\"}")]
        public virtual oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsVulnerabilityAuditSummaryCollectionList VulnerabilityAuditSummaryCollection
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputsVulnerabilityAuditSummaryCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDevopsBuildRun.DataOciDevopsBuildRunBuildOutputs\"}", isOptional: true)]
        public virtual oci.DataOciDevopsBuildRun.IDataOciDevopsBuildRunBuildOutputs? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDevopsBuildRun.IDataOciDevopsBuildRunBuildOutputs?>();
            set => SetInstanceProperty(value);
        }
    }
}
