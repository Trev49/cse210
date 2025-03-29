using Raylib_cs;

class GameManager
{
    public const int SCREEN_WIDTH = 800;
    public const int SCREEN_HEIGHT = 600;

    private string _title;
    private List<GameObject> _gameObjects = new List<GameObject>();
    private int _score;
    private int _lives = 3;
    private Player _player;
    private int _level = 1;
    private int _levelUpScore = 0;


    public GameManager()
    {
        _title = "CSE 210 Game";
    }

    /// <summary>
    /// The overall loop that controls the game. It calls functions to
    /// handle interactions, update game elements, and draw the screen.
    /// </summary>
    public void Run()
    {
        Raylib.SetTargetFPS(60);
        Raylib.InitWindow(SCREEN_WIDTH, SCREEN_HEIGHT, _title);
        // If using sound, un-comment the lines to init and close the audio device
        // Raylib.InitAudioDevice();

        InitializeGame();

        while (!Raylib.WindowShouldClose())
        {
            HandleInput();
            ProcessActions();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            DrawElements();
            Raylib.DrawText($"Score: {_score}", 10, 10, 20, Color.Black);
            Raylib.DrawText($"Lives: {_lives}", 10, 40, 20, Color.Black);
            Raylib.DrawText($"Level: {_level}", 10, 70, 20, Color.Black);

            if (_lives <= 0)
            {
                Raylib.DrawText("Game Over", SCREEN_WIDTH / 2 - 50, SCREEN_HEIGHT / 2, 30, Color.Red);
            }

            Raylib.EndDrawing();
        }

        // Raylib.CloseAudioDevice();
        Raylib.CloseWindow();
    }

    /// <summary>
    /// Sets up the initial conditions for the game.
    /// </summary>
    private void InitializeGame()
    {
        _player = new Player(SCREEN_WIDTH / 2, SCREEN_HEIGHT - 50);

        _gameObjects.Add(_player);

        for (int i = 0; i < 3 * _level; i++)
        {
            Treasure treasure = new Treasure(50 + (i * 50), 50, 1, 2 + _level, Color.Gold);
            _gameObjects.Add(treasure);
        }
        for (int i = 0; i < 3 * _level; i++)
        {
            Bomb bomb = new Bomb(200 + (i * 100), 50, -5, 2 + _level);
            _gameObjects.Add(bomb);
        }

    }

    /// <summary>
    /// Responds to any input from the user.
    /// </summary>
    private void HandleInput()
    {
        _player.Move();
    }

    /// <summary>
    /// Processes any actions such as moving objects or handling collisions.
    /// </summary>
    private void ProcessActions()
    {
        List<GameObject> toRemove = new List<GameObject>();
        List<GameObject> toAdd = new List<GameObject>();

        foreach (GameObject obj in _gameObjects)
        {
            if (obj is FallingObject fallingObj)
            {
                fallingObj.Fall();

                if (Raylib.CheckCollisionRecs(_player.GetBounds(), fallingObj.GetBounds()))
                {
                    if (fallingObj is Treasure)
                    {
                        _score += fallingObj.GetValue();
                        _levelUpScore += fallingObj.GetValue();
                        if (_levelUpScore >= 10 * _level)
                        {
                            _level++;
                            for (int i = 0; i < 2; i++)
                            {
                                if (Raylib.GetRandomValue(0, 100) < 20)
                                {

                                    Treasure RareTreasure = new Treasure(Raylib.GetRandomValue(0, SCREEN_WIDTH - 20), 0, 10, 2 + _level, Color.Green);
                                    toAdd.Add(RareTreasure);

                                }
                                Treasure extraTreasure = new Treasure(Raylib.GetRandomValue(0, SCREEN_WIDTH - 20), 0, 1, 2 + _level, Color.Gold);
                                toAdd.Add(extraTreasure);
                            }
                            for (int i = 0; i < 1; i++)
                            {
                                Bomb extraBomb = new Bomb(Raylib.GetRandomValue(0, SCREEN_WIDTH - 20), 0, -5, 2 + _level);
                                toAdd.Add(extraBomb);
                            }
                        }
                    }
                    else if (fallingObj is Bomb)
                    {
                        _lives--;
                        if (_lives <= 0)
                        {
                            _gameObjects.Clear();
                            return;
                        }
                    }
                    toRemove.Add(obj);
                    FallingObject newObj;
                    if (fallingObj is Treasure)
                    {
                        newObj = new Treasure(Raylib.GetRandomValue(0, GameManager.SCREEN_WIDTH - 20), 0, 1, 2 + _level, Color.Gold);
                    }
                    else
                    {
                        newObj = new Bomb(Raylib.GetRandomValue(0, GameManager.SCREEN_WIDTH - 20), 0, -5, 2 + _level);
                    }

                    toAdd.Add(newObj);
                }
            }
        }

        foreach (var obj in toRemove)
        {
            _gameObjects.Remove(obj);
        }

        _gameObjects.AddRange(toAdd);
    }


    /// <summary>
    /// Draws all elements on the screen.
    /// </summary>
    private void DrawElements()
    {
        foreach (GameObject item in _gameObjects)
        {
            item.Draw();
        }
    }
}