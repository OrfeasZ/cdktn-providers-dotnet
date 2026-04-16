using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayEdgeServicesBackendStage
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayEdgeServicesBackendStage.DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfigOutputReference), fullyQualifiedName: "scaleway.dataScalewayEdgeServicesBackendStage.DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrontendId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hasWebsocket", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasWebsocket
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSsl", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSsl
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayEdgeServicesBackendStage.DataScalewayEdgeServicesBackendStageLbBackendConfigLbConfig\"}", isOptional: true)]
        public virtual scaleway.DataScalewayEdgeServicesBackendStage.IDataScalewayEdgeServicesBackendStageLbBackendConfigLbConfig? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayEdgeServicesBackendStage.IDataScalewayEdgeServicesBackendStageLbBackendConfigLbConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
