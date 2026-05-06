using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactOutputReference), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementPatchArtifactDetailsArtifactOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementPatchArtifactDetailsArtifactOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementPatchArtifactDetailsArtifactOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementPatchArtifactDetailsArtifactOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContent\"}}]")]
        public virtual void PutContent(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContent")]
        public virtual void ResetContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContentOutputReference\"}")]
        public virtual oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContentOutputReference Content
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContentOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactContent\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent? ContentInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifactContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact?>();
            set => SetInstanceProperty(value);
        }
    }
}
