using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPatch
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsOutputReference), fullyQualifiedName: "oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementPatchArtifactDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementPatchArtifactDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FleetAppsManagementPatchArtifactDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementPatchArtifactDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArtifact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact\"}}]")]
        public virtual void PutArtifact(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putArtifacts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifacts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutArtifacts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifacts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifacts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifacts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArtifact")]
        public virtual void ResetArtifact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetArtifacts")]
        public virtual void ResetArtifacts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "artifact", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactOutputReference\"}")]
        public virtual oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactOutputReference Artifact
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactOutputReference>()!;
        }

        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactsList\"}")]
        public virtual oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactsList Artifacts
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifactsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifact\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact? ArtifactInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetailsArtifact?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetailsArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ArtifactsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPatch.FleetAppsManagementPatchArtifactDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPatch.IFleetAppsManagementPatchArtifactDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
