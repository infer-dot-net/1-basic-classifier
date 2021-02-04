// <auto-generated />
#pragma warning disable 1570, 1591

using System;
using Microsoft.ML.Probabilistic;
using Microsoft.ML.Probabilistic.Distributions;
using Microsoft.ML.Probabilistic.Factors;

namespace Models
{
	/// <summary>
	/// Generated algorithm for performing inference.
	/// </summary>
	/// <remarks>
	/// If you wish to use this class directly, you must perform the following steps:
	/// 1) Create an instance of the class.
	/// 2) Set the value of any externally-set fields e.g. data, priors.
	/// 3) Call the Execute(numberOfIterations) method.
	/// 4) Use the XXXMarginal() methods to retrieve posterior marginals for different variables.
	/// 
	/// Generated by Infer.NET 0.3.1912.403 at 08:55 on Thursday, 04 February 2021.
	/// </remarks>
	public partial class Model_EP : IGeneratedAlgorithm
	{
		#region Fields
		/// <summary>True if Changed_featureValue_isSetosa_numberOfIterations has executed. Set this to false to force re-execution of Changed_featureValue_isSetosa_numberOfIterations</summary>
		public bool Changed_featureValue_isSetosa_numberOfIterations_isDone;
		/// <summary>True if Changed_isSetosa has executed. Set this to false to force re-execution of Changed_isSetosa</summary>
		public bool Changed_isSetosa_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa has executed. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa</summary>
		public bool Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isDone;
		/// <summary>True if Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa has performed initialisation. Set this to false to force re-execution of Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa</summary>
		public bool Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isInitialised;
		/// <summary>True if Constant has executed. Set this to false to force re-execution of Constant</summary>
		public bool Constant_isDone;
		/// <summary>Field backing the featureValue property</summary>
		private double[] FeatureValue;
		/// <summary>Field backing the isSetosa property</summary>
		private bool[] IsSetosa;
		public DistributionStructArray<Bernoulli,bool> isSetosa_marginal;
		/// <summary>Field backing the NumberOfIterationsDone property</summary>
		private int numberOfIterationsDone;
		public Gaussian threshold_F;
		/// <summary>Message to marginal of 'threshold'</summary>
		public Gaussian threshold_marginal_F;
		public DistributionStructArray<Gaussian,double> threshold_rep_B;
		/// <summary>Buffer for ReplicateOp_Divide.Marginal<Gaussian></summary>
		public Gaussian threshold_rep_B_toDef;
		/// <summary>Buffer for ReplicateOp_Divide.UsesAverageConditional<Gaussian></summary>
		public Gaussian threshold_rep_F_marginal;
		public Gaussian weight_F;
		/// <summary>Message to marginal of 'weight'</summary>
		public Gaussian weight_marginal_F;
		public DistributionStructArray<Gaussian,double> weight_rep_B;
		/// <summary>Buffer for ReplicateOp_Divide.Marginal<Gaussian></summary>
		public Gaussian weight_rep_B_toDef;
		/// <summary>Buffer for ReplicateOp_Divide.UsesAverageConditional<Gaussian></summary>
		public Gaussian weight_rep_F_marginal;
		#endregion

		#region Properties
		/// <summary>The externally-specified value of 'featureValue'</summary>
		public double[] featureValue
		{
			get {
				return this.FeatureValue;
			}
			set {
				if ((value!=null)&&(value.Length!=100)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+100)+" was expected for variable \'featureValue\'");
				}
				this.FeatureValue = value;
				this.numberOfIterationsDone = 0;
				this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isInitialised = false;
				this.Changed_featureValue_isSetosa_numberOfIterations_isDone = false;
			}
		}

		/// <summary>The externally-specified value of 'isSetosa'</summary>
		public bool[] isSetosa
		{
			get {
				return this.IsSetosa;
			}
			set {
				if ((value!=null)&&(value.Length!=100)) {
					throw new ArgumentException(((("Provided array of length "+value.Length)+" when length ")+100)+" was expected for variable \'isSetosa\'");
				}
				this.IsSetosa = value;
				this.numberOfIterationsDone = 0;
				this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isInitialised = false;
				this.Changed_featureValue_isSetosa_numberOfIterations_isDone = false;
				this.Changed_isSetosa_isDone = false;
			}
		}

		/// <summary>The number of iterations done from the initial state</summary>
		public int NumberOfIterationsDone
		{
			get {
				return this.numberOfIterationsDone;
			}
		}

		#endregion

		#region Methods
		/// <summary>Computations that depend on the observed value of featureValue and isSetosa and numberOfIterations</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		private void Changed_featureValue_isSetosa_numberOfIterations(int numberOfIterations)
		{
			if (this.Changed_featureValue_isSetosa_numberOfIterations_isDone) {
				return ;
			}
			this.weight_marginal_F = Gaussian.Uniform();
			// Message to 'weight' from GaussianFromMeanAndVariance factor
			this.weight_F = GaussianFromMeanAndVarianceOp.SampleAverageConditional(0.0, 1.0);
			// Message to 'threshold' from GaussianFromMeanAndVariance factor
			this.threshold_F = GaussianFromMeanAndVarianceOp.SampleAverageConditional(0.0, 10.0);
			DistributionStructArray<Gaussian,double> weight_rep_F;
			// Create array for 'weight_rep' Forwards messages.
			weight_rep_F = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				weight_rep_F[n] = Gaussian.Uniform();
			}
			// Create array for replicates of 'score_F'
			DistributionStructArray<Gaussian,double> score_F = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				score_F[n] = Gaussian.Uniform();
			}
			// Create array for replicates of 'noisyScore_F'
			DistributionStructArray<Gaussian,double> noisyScore_F = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				noisyScore_F[n] = Gaussian.Uniform();
			}
			// Create array for replicates of 'vdouble11_F'
			DistributionStructArray<Gaussian,double> vdouble11_F = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				vdouble11_F[n] = Gaussian.Uniform();
			}
			// Create array for replicates of 'vdouble11_B'
			DistributionStructArray<Gaussian,double> vdouble11_B = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				vdouble11_B[n] = Gaussian.Uniform();
			}
			DistributionStructArray<Gaussian,double> threshold_rep_F;
			// Create array for 'threshold_rep' Forwards messages.
			threshold_rep_F = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				threshold_rep_F[n] = Gaussian.Uniform();
			}
			// Create array for replicates of 'noisyScore_use_B'
			DistributionStructArray<Gaussian,double> noisyScore_use_B = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				noisyScore_use_B[n] = Gaussian.Uniform();
			}
			// Create array for replicates of 'score_B'
			DistributionStructArray<Gaussian,double> score_B = new DistributionStructArray<Gaussian,double>(100);
			for(int n = 0; n<100; n++) {
				score_B[n] = Gaussian.Uniform();
			}
			for(int iteration = this.numberOfIterationsDone; iteration<numberOfIterations; iteration++) {
				// Message to 'threshold_rep' from Replicate factor
				this.threshold_rep_F_marginal = ReplicateOp_Divide.Marginal<Gaussian>(this.threshold_rep_B_toDef, this.threshold_F, this.threshold_rep_F_marginal);
				// Message to 'weight_rep' from Replicate factor
				this.weight_rep_F_marginal = ReplicateOp_Divide.Marginal<Gaussian>(this.weight_rep_B_toDef, this.weight_F, this.weight_rep_F_marginal);
				for(int n = 0; n<100; n++) {
					// Message to 'threshold_rep' from Replicate factor
					threshold_rep_F[n] = ReplicateOp_Divide.UsesAverageConditional<Gaussian>(this.threshold_rep_B[n], this.threshold_rep_F_marginal, n, threshold_rep_F[n]);
					// Message to 'weight_rep' from Replicate factor
					weight_rep_F[n] = ReplicateOp_Divide.UsesAverageConditional<Gaussian>(this.weight_rep_B[n], this.weight_rep_F_marginal, n, weight_rep_F[n]);
					// Message to 'score' from Product factor
					score_F[n] = GaussianProductOpBase.ProductAverageConditional(this.FeatureValue[n], weight_rep_F[n]);
					// Message to 'noisyScore' from GaussianFromMeanAndVariance factor
					noisyScore_F[n] = GaussianFromMeanAndVarianceOp.SampleAverageConditional(score_F[n], 100.0);
					// Message to 'vdouble11' from Difference factor
					vdouble11_F[n] = DoublePlusOp.AAverageConditional(noisyScore_F[n], threshold_rep_F[n]);
					// Message to 'vdouble11' from IsPositive factor
					vdouble11_B[n] = IsPositiveOp_Proper.XAverageConditional(Bernoulli.PointMass(this.IsSetosa[n]), vdouble11_F[n]);
					// Message to 'noisyScore_use' from Difference factor
					noisyScore_use_B[n] = DoublePlusOp.SumAverageConditional(vdouble11_B[n], threshold_rep_F[n]);
					// Message to 'score' from GaussianFromMeanAndVariance factor
					score_B[n] = GaussianFromMeanAndVarianceOp.MeanAverageConditional(noisyScore_use_B[n], 100.0);
					// Message to 'weight_rep' from Product factor
					this.weight_rep_B[n] = GaussianProductOpBase.BAverageConditional(score_B[n], this.FeatureValue[n]);
					// Message to 'threshold_rep' from Difference factor
					this.threshold_rep_B[n] = DoublePlusOp.BAverageConditional(noisyScore_F[n], vdouble11_B[n]);
					this.threshold_rep_F_marginal = ReplicateOp_Divide.MarginalIncrement<Gaussian>(this.threshold_rep_F_marginal, threshold_rep_F[n], this.threshold_rep_B[n]);
					this.weight_rep_F_marginal = ReplicateOp_Divide.MarginalIncrement<Gaussian>(this.weight_rep_F_marginal, weight_rep_F[n], this.weight_rep_B[n]);
				}
				// Message to 'weight_rep' from Replicate factor
				this.weight_rep_B_toDef = ReplicateOp_Divide.ToDef<Gaussian>(this.weight_rep_B, this.weight_rep_B_toDef);
				// Message to 'threshold_rep' from Replicate factor
				this.threshold_rep_B_toDef = ReplicateOp_Divide.ToDef<Gaussian>(this.threshold_rep_B, this.threshold_rep_B_toDef);
				this.OnProgressChanged(new ProgressChangedEventArgs(iteration));
			}
			// Message to 'weight_marginal' from Variable factor
			this.weight_marginal_F = VariableOp.MarginalAverageConditional<Gaussian>(this.weight_rep_B_toDef, this.weight_F, this.weight_marginal_F);
			this.threshold_marginal_F = Gaussian.Uniform();
			// Message to 'threshold_marginal' from Variable factor
			this.threshold_marginal_F = VariableOp.MarginalAverageConditional<Gaussian>(this.threshold_rep_B_toDef, this.threshold_F, this.threshold_marginal_F);
			this.Changed_featureValue_isSetosa_numberOfIterations_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of isSetosa</summary>
		private void Changed_isSetosa()
		{
			if (this.Changed_isSetosa_isDone) {
				return ;
			}
			this.isSetosa_marginal = new DistributionStructArray<Bernoulli,bool>(100, delegate(int n) {
				return Bernoulli.Uniform();
			});
			this.isSetosa_marginal = Distribution.SetPoint<DistributionStructArray<Bernoulli,bool>,bool[]>(this.isSetosa_marginal, this.IsSetosa);
			this.Changed_isSetosa_isDone = true;
		}

		/// <summary>Computations that depend on the observed value of numberOfIterationsDecreased and must reset on changes to featureValue and isSetosa</summary>
		/// <param name="initialise">If true, reset messages that initialise loops</param>
		private void Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa(bool initialise)
		{
			if (this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isDone&&((!initialise)||this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isInitialised)) {
				return ;
			}
			// Message to 'weight_rep' from Replicate factor
			this.weight_rep_F_marginal = ReplicateOp_Divide.MarginalInit<Gaussian>(this.weight_F);
			// Message to 'weight_rep' from Replicate factor
			this.weight_rep_B_toDef = ReplicateOp_Divide.ToDefInit<Gaussian>(this.weight_F);
			// Message to 'threshold_rep' from Replicate factor
			this.threshold_rep_F_marginal = ReplicateOp_Divide.MarginalInit<Gaussian>(this.threshold_F);
			// Message to 'threshold_rep' from Replicate factor
			this.threshold_rep_B_toDef = ReplicateOp_Divide.ToDefInit<Gaussian>(this.threshold_F);
			for(int n = 0; n<100; n++) {
				this.threshold_rep_B[n] = Gaussian.Uniform();
				this.weight_rep_B[n] = Gaussian.Uniform();
			}
			this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isDone = true;
			this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isInitialised = true;
		}

		/// <summary>Computations that do not depend on observed values</summary>
		private void Constant()
		{
			if (this.Constant_isDone) {
				return ;
			}
			this.weight_F = Gaussian.Uniform();
			this.threshold_F = Gaussian.Uniform();
			// Create array for 'threshold_rep' Backwards messages.
			this.threshold_rep_B = new DistributionStructArray<Gaussian,double>(100);
			// Create array for 'weight_rep' Backwards messages.
			this.weight_rep_B = new DistributionStructArray<Gaussian,double>(100);
			this.Constant_isDone = true;
		}

		/// <summary>Update all marginals, by iterating message passing the given number of times</summary>
		/// <param name="numberOfIterations">The number of times to iterate each loop</param>
		/// <param name="initialise">If true, messages that initialise loops are reset when observed values change</param>
		private void Execute(int numberOfIterations, bool initialise)
		{
			if (numberOfIterations!=this.numberOfIterationsDone) {
				if (numberOfIterations<this.numberOfIterationsDone) {
					this.numberOfIterationsDone = 0;
					this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa_isDone = false;
				}
				this.Changed_featureValue_isSetosa_numberOfIterations_isDone = false;
			}
			this.Constant();
			this.Changed_numberOfIterationsDecreased_Init_featureValue_isSetosa(initialise);
			this.Changed_featureValue_isSetosa_numberOfIterations(numberOfIterations);
			this.Changed_isSetosa();
			this.numberOfIterationsDone = numberOfIterations;
		}

		/// <summary>Update all marginals, by iterating message-passing the given number of times</summary>
		/// <param name="numberOfIterations">The total number of iterations that should be executed for the current set of observed values.  If this is more than the number already done, only the extra iterations are done.  If this is less than the number already done, message-passing is restarted from the beginning.  Changing the observed values resets the iteration count to 0.</param>
		public void Execute(int numberOfIterations)
		{
			this.Execute(numberOfIterations, true);
		}

		/// <summary>Get the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		public object GetObservedValue(string variableName)
		{
			if (variableName=="featureValue") {
				return this.featureValue;
			}
			if (variableName=="isSetosa") {
				return this.isSetosa;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>
		/// Returns the marginal distribution for 'isSetosa' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public DistributionStructArray<Bernoulli,bool> IsSetosaMarginal()
		{
			return this.isSetosa_marginal;
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName)
		{
			if (variableName=="weight") {
				return this.WeightMarginal();
			}
			if (variableName=="threshold") {
				return this.ThresholdMarginal();
			}
			if (variableName=="isSetosa") {
				return this.IsSetosaMarginal();
			}
			throw new ArgumentException("This class was not built to infer "+variableName);
		}

		/// <summary>Get the marginal distribution (computed up to this point) of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <returns>The marginal distribution computed up to this point</returns>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName));
		}

		/// <summary>Get the query-specific marginal distribution of a variable.</summary>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public object Marginal(string variableName, string query)
		{
			if (query=="Marginal") {
				return this.Marginal(variableName);
			}
			throw new ArgumentException(((("This class was not built to infer \'"+variableName)+"\' with query \'")+query)+"\'");
		}

		/// <summary>Get the query-specific marginal distribution of a variable, converted to type T</summary>
		/// <typeparam name="T">The distribution type.</typeparam>
		/// <param name="variableName">Name of the variable in the generated code</param>
		/// <param name="query">QueryType name. For example, GibbsSampling answers 'Marginal', 'Samples', and 'Conditionals' queries</param>
		/// <remarks>Execute, Update, or Reset must be called first to set the value of the marginal.</remarks>
		public T Marginal<T>(string variableName, string query)
		{
			return Distribution.ChangeType<T>(this.Marginal(variableName, query));
		}

		private void OnProgressChanged(ProgressChangedEventArgs e)
		{
			// Make a temporary copy of the event to avoid a race condition
			// if the last subscriber unsubscribes immediately after the null check and before the event is raised.
			EventHandler<ProgressChangedEventArgs> handler = this.ProgressChanged;
			if (handler!=null) {
				handler(this, e);
			}
		}

		/// <summary>Reset all messages to their initial values.  Sets NumberOfIterationsDone to 0.</summary>
		public void Reset()
		{
			this.Execute(0);
		}

		/// <summary>Set the observed value of the specified variable.</summary>
		/// <param name="variableName">Variable name</param>
		/// <param name="value">Observed value</param>
		public void SetObservedValue(string variableName, object value)
		{
			if (variableName=="featureValue") {
				this.featureValue = (double[])value;
				return ;
			}
			if (variableName=="isSetosa") {
				this.isSetosa = (bool[])value;
				return ;
			}
			throw new ArgumentException("Not an observed variable name: "+variableName);
		}

		/// <summary>
		/// Returns the marginal distribution for 'threshold' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian ThresholdMarginal()
		{
			return this.threshold_marginal_F;
		}

		/// <summary>Update all marginals, by iterating message-passing an additional number of times</summary>
		/// <param name="additionalIterations">The number of iterations that should be executed, starting from the current message state.  Messages are not reset, even if observed values have changed.</param>
		public void Update(int additionalIterations)
		{
			this.Execute(checked(this.numberOfIterationsDone+additionalIterations), false);
		}

		/// <summary>
		/// Returns the marginal distribution for 'weight' given by the current state of the
		/// message passing algorithm.
		/// </summary>
		/// <returns>The marginal distribution</returns>
		public Gaussian WeightMarginal()
		{
			return this.weight_marginal_F;
		}

		#endregion

		#region Events
		/// <summary>Event that is fired when the progress of inference changes, typically at the end of one iteration of the inference algorithm.</summary>
		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
		#endregion

	}

}
