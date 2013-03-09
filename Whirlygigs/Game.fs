namespace Whirlygigs
open System
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

/// Default Project Template
type WhirlygigsGame() as this =
  inherit Game()
  let graphics = new GraphicsDeviceManager(this)
  let gig = new Gig()
  
  /// Overridden from the base Game.Initialize. Once the GraphicsDevice is setup,
  /// we'll use the viewport to initialize some values.
  override this.Initialize() =
    // Set the directory from which to find content
    this.Content.RootDirectory <- "Content"
    graphics.IsFullScreen <- false
    this.IsMouseVisible <- true
    gig.Initialize this
    base.Initialize()

  /// Load your graphics content.
  override this.LoadContent() =
    gig.LoadContent ()
    
  /// Allows the game to run logic such as updating the world,
  /// checking for collisions, gathering input, and playing audio.
  override x.Update (gameTime:GameTime) =
    // Update the gig, so it can spin
    gig.Update ()
  
  /// This is called when the game should draw itself.
  override x.Draw (gameTime:GameTime) =
    // Clear the backbuffer
    graphics.GraphicsDevice.Clear (Color.CornflowerBlue)
    // Draw the gig
    gig.Draw ()