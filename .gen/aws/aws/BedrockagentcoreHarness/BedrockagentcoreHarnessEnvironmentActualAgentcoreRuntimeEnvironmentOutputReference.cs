using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiClass(nativeType: typeof(aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentOutputReference), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentRuntimeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentRuntimeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "agentRuntimeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentRuntimeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filesystemConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentFilesystemConfigurationList\"}")]
        public virtual aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentFilesystemConfigurationList FilesystemConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentFilesystemConfigurationList>()!;
        }

        [JsiiProperty(name: "lifecycleConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentLifecycleConfigurationList\"}")]
        public virtual aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentLifecycleConfigurationList LifecycleConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentLifecycleConfigurationList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentNetworkConfigurationList\"}")]
        public virtual aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<aws.BedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironmentNetworkConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironment\"}", isOptional: true)]
        public virtual aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironment? InternalValue
        {
            get => GetInstanceProperty<aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessEnvironmentActualAgentcoreRuntimeEnvironment?>();
            set => SetInstanceProperty(value);
        }
    }
}
